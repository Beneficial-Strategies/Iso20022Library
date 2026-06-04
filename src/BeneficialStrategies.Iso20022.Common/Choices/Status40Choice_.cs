// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.Status40Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for an order status report.</summary>
    [IsoId("9c6c2280-d031-470c-8e00-427341a7ecba")]
    [DisplayName("Status 40 Choice")]
    [KnownType(typeof(Status40Choice.OrderDetailsReport))]
    [KnownType(typeof(Status40Choice.IndividualOrderDetailsReport))]
    [KnownType(typeof(Status40Choice.SwitchOrderDetailsReport))]
    [JsonDerivedType(typeof(Status40Choice.OrderDetailsReport))]
    [JsonDerivedType(typeof(Status40Choice.IndividualOrderDetailsReport))]
    [JsonDerivedType(typeof(Status40Choice.SwitchOrderDetailsReport))]
    public abstract record Status40Choice_
    {
    }
}
