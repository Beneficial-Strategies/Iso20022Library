// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.CashDeliveryMethod1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies the delivery method for the cash deposit.</summary>
    [IsoId("_btJ0EOOwEe-NFYIkYc90gw")]
    [DisplayName("Cash Delivery Method 1 Choice")]
    [KnownType(typeof(CashDeliveryMethod1Choice.Code))]
    [KnownType(typeof(CashDeliveryMethod1Choice.Proprietary))]
    [JsonDerivedType(typeof(CashDeliveryMethod1Choice.Code))]
    [JsonDerivedType(typeof(CashDeliveryMethod1Choice.Proprietary))]
    public abstract record CashDeliveryMethod1Choice_
    {
    }
}
