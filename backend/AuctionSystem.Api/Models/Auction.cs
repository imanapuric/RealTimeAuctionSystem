namespace AuctionSystem.Api.Models;

public class Auction
{
    public int AuctionId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal StartingPrice { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int CreatedByUserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<Bid> Bids { get; set; } = new List<Bid>();
}
