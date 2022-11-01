using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xuexiaojie.Models;

namespace xuexiaojie.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        [HttpGet]
        public async  Task<ActionResult<item>> QueryItemData(string title)
        {
            
            var data = new item();
            using (MyDbContext db = new MyDbContext())
            {
                data =  db.item.SingleOrDefault(t => t.title == title);                
            }
            return data;
        }
        [HttpPost]
        public async Task<ActionResult<string>> CreateOrder(string title,double price,int num)
        {

            using (MyDbContext db = new MyDbContext())
            {
                var data = db.item.Single(t => t.title == title);
                if (data == null)
                    return "商品不存在";
                if (data.num < num || data.num <= 0)
                    return "库存量不足";
                data.num -= num;
                var order = new E_order();
                order.TotalQuantity = num;
                order.TotalAmount = num * price;
                db.Update(data);
                db.Add(order);
                await db.SaveChangesAsync();   //需要await，不然using里的代码块完结后，线程上下文中的数据会被释放掉，有时候会保持失败  
            }
            return "操作成功";
        }

        [HttpPost]
        public async Task<ActionResult<string>> UpdateItem(string title, double price, int num)
        {
            if (string.IsNullOrEmpty(title))
                return "商品名称不能为空";
            using (MyDbContext db = new MyDbContext())
            {
                var data = db.item.SingleOrDefault(t => t.title == title);//查询不到时复制默认值，避免报错
                if (data == null)
                    return "找不到该商品信息";
                data.title = title;
                data.price = price;
                data.num = num;
                db.Update(data);
                await db.SaveChangesAsync();
            }
            return  "修改成功";
        }
    }
}
