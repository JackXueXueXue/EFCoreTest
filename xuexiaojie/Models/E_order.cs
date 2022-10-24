namespace xuexiaojie.Models
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class E_order
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 订单总额
        /// </summary>
        public double TotalAmount { get; set; }

        /// <summary>
        /// 商品总数量
        /// </summary>
        public int TotalQuantity { get; set; }
    }
}
