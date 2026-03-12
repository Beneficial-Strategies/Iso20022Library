// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a fixed rate and a variable rate.
    /// </summary>
    [KnownType(typeof(InterestRate1Choice.FixedInterestRate))]
    [KnownType(typeof(InterestRate1Choice.VariableInterestRate))]
    [JsonDerivedType(typeof(InterestRate1Choice.FixedInterestRate),nameof(InterestRate1Choice.FixedInterestRate))]
    [JsonDerivedType(typeof(InterestRate1Choice.VariableInterestRate),nameof(InterestRate1Choice.VariableInterestRate))]
    [IsoId("_Qk1wctp-Ed-ak6NoX_4Aeg_-868217621")]
    [DisplayName("Interest Rate 1 Choice")]
    public abstract partial record InterestRate1Choice_
    {
    }
}
