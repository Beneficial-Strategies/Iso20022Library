// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the classification of a financial institution.
    /// </summary>
    [KnownType(typeof(FinancialPartyClassification2Choice.Code))]
    [KnownType(typeof(FinancialPartyClassification2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(FinancialPartyClassification2Choice.Code),
        nameof(FinancialPartyClassification2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FinancialPartyClassification2Choice.Proprietary),
        nameof(FinancialPartyClassification2Choice.Proprietary)
    )]
    [IsoId("_IH7-oSI4Ee2zWP9pqvmqdw")]
    [DisplayName("Financial Party Classification 2 Choice")]
    public abstract record FinancialPartyClassification2Choice_ { }
}
