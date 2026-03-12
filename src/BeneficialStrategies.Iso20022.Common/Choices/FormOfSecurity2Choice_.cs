// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the form of securities.
    /// </summary>
    [KnownType(typeof(FormOfSecurity2Choice.Code))]
    [KnownType(typeof(FormOfSecurity2Choice.Proprietary))]
    [JsonDerivedType(typeof(FormOfSecurity2Choice.Code),nameof(FormOfSecurity2Choice.Code))]
    [JsonDerivedType(typeof(FormOfSecurity2Choice.Proprietary),nameof(FormOfSecurity2Choice.Proprietary))]
    [IsoId("_QvHt1tp-Ed-ak6NoX_4Aeg_-1274375071")]
    [DisplayName("Form Of Security 2 Choice")]
    public abstract partial record FormOfSecurity2Choice_
    {
    }
}
