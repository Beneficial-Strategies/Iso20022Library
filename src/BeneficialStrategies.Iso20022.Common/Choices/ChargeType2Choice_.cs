// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the charge type.
    /// </summary>
    [KnownType(typeof(ChargeType2Choice.Code))]
    [KnownType(typeof(ChargeType2Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType2Choice.Code),nameof(ChargeType2Choice.Code))]
    [JsonDerivedType(typeof(ChargeType2Choice.Proprietary),nameof(ChargeType2Choice.Proprietary))]
    [IsoId("_RvC5w9p-Ed-ak6NoX_4Aeg_-1781938940")]
    [DisplayName("Charge Type 2 Choice")]
    public abstract partial record ChargeType2Choice_
    {
    }
}
