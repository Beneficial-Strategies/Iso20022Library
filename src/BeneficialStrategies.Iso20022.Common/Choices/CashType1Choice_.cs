// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.CashType1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies the cash type.</summary>
    [IsoId("_R9pcY1DeEfCRhs5qxCujTw")]
    [DisplayName("Cash Type 1 Choice")]
    [KnownType(typeof(CashType1Choice.Code))]
    [KnownType(typeof(CashType1Choice.Proprietary))]
    [JsonDerivedType(typeof(CashType1Choice.Code))]
    [JsonDerivedType(typeof(CashType1Choice.Proprietary))]
    public abstract record CashType1Choice_
    {
    }
}
