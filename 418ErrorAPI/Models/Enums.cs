namespace _418ErrorAPI.Models;

public enum RefundStatus
{
    Required,
    InProgress,
    Approved,
    Dismissed
}

public enum LoyaltyType
{
    Membership,
    ClubCard,
    SpendBased
}

public enum RefundType
{
    Partial,
    Full
}

public enum ProductQuantityType
{
    Liters,
    Kilograms,
    Units
}

public enum PromoCodeValueType
{
    Percentage,
    FixedAmmountOfMoney
}

public enum DiscountType
{
    Percentage,
    Overstocked,
    FreeShipping,
    OneFree
}

public enum OrderStatus
{
    Pending,
    AwaitingPayment,
    AwaitingShippment,
    Shipped,
    Completed,
    CancelledByCustomer,
    CacelledBySeller,
    Refunded,
    PartiallyRefunded
}

public enum ReportType
{
    StaffMemberStatistics,
    MoneyTransactions,
    EmployeeTimetables,
    StorageReport,
    SalesStatistics
}

/*public class Enums
{
}*/
