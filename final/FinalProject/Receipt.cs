
class Receipt
{

    public Receipt(string plate, DateTime receiptDate, double totalAmount, DateTime checkIn, DateTime checkOut)
    {
        Plate = plate;
        ReceiptDate = receiptDate;
        TotalAmount = totalAmount;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public override string ToString()
    {
        return $"Plate: {Plate}\n" +
               $"Receipt Date: {ReceiptDate.ToShortDateString()}\n" +
               $"Total Amount: {TotalAmount}\n" +
               $"Check In: {CheckIn}\n" +
               $"Check Out: {CheckOut}\n";
    }

    public string Plate { get; set; }
    public DateTime ReceiptDate { get; set; }
    public double TotalAmount { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }


}