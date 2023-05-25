
class Receipt
{
    public Receipt(long iDReceipt, string plate, DateTime receiptDate, double totalAmount, DateTime checkIn, DateTime checkOut)
    {
        IDReceipt = iDReceipt;
        Plate = plate;
        ReceiptDate = receiptDate;
        TotalAmount = totalAmount;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public long IDReceipt { get; set; }
    public string Plate { get; set; }
    public DateTime ReceiptDate { get; set; }
    public double TotalAmount { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }


}