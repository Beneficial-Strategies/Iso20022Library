// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the stamp duty information.
    /// </summary>
    [KnownType(typeof(StampDutyType1FormatChoice.Code))]
    [KnownType(typeof(StampDutyType1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(StampDutyType1FormatChoice.Code),nameof(StampDutyType1FormatChoice.Code))]
    [JsonDerivedType(typeof(StampDutyType1FormatChoice.Proprietary),nameof(StampDutyType1FormatChoice.Proprietary))]
    [IsoId("_Ro8Rxtp-Ed-ak6NoX_4Aeg_-891645005")]
    [DisplayName("Stamp Duty Type 1 Format Choice")]
    public abstract partial record StampDutyType1FormatChoice_
    {
    }
}
