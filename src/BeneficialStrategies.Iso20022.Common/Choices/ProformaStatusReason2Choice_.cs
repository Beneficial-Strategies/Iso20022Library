// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a proforma reason code.
    /// </summary>
    [KnownType(typeof(ProformaStatusReason2Choice.Code))]
    [KnownType(typeof(ProformaStatusReason2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProformaStatusReason2Choice.Code),
        nameof(ProformaStatusReason2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ProformaStatusReason2Choice.Proprietary),
        nameof(ProformaStatusReason2Choice.Proprietary)
    )]
    [IsoId("_MFm9IUzDEeafiMTDrtSnyw")]
    [DisplayName("Proforma Status Reason 2 Choice")]
    public abstract record ProformaStatusReason2Choice_ { }
}
