using System;

namespace xuexiaojie.Models
{
    /// <summary>
    /// 商品表
    /// </summary>
    public class item
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 商品价格，单位分
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// 商品库存
        /// </summary>
        public int num { get; set; }
    }
}
