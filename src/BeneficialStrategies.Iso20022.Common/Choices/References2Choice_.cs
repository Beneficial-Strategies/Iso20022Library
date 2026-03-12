// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References2Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References2Choice.SecuritiesFinancingTransactionIdentification))]
    [KnownType(typeof(References2Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References2Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References2Choice.SecuritiesSettlementTransactionIdentification),nameof(References2Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References2Choice.SecuritiesFinancingTransactionIdentification),nameof(References2Choice.SecuritiesFinancingTransactionIdentification))]
    [JsonDerivedType(typeof(References2Choice.IntraPositionMovementIdentification),nameof(References2Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References2Choice.OtherTransactionIdentification),nameof(References2Choice.OtherTransactionIdentification))]
    [IsoId("_US9oCdp-Ed-ak6NoX_4Aeg_1980096839")]
    [DisplayName("References 2 Choice")]
    public abstract partial record References2Choice_
    {
    }
}
