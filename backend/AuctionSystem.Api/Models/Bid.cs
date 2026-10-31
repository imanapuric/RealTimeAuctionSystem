namespace AuctionSystem.Api.Models;

public class Bid
{
    public int BidId { get; set; }
    public int AuctionId { get; set; }
    public Auction Auction { get; set; } = null!;
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public decimal Amount { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
