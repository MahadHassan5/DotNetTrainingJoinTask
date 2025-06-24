using System;

public class Book : BaseEntity
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public int Quantity { get; set; }

    public BookStatus Status => Quantity > 0 ? BookStatus.Available : BookStatus.Borrowed;
}
