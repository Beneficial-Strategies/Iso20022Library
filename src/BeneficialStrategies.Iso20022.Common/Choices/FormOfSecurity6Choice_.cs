// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the form of securities.
    /// </summary>
    [KnownType(typeof(FormOfSecurity6Choice.Code))]
    [KnownType(typeof(FormOfSecurity6Choice.Proprietary))]
    [JsonDerivedType(typeof(FormOfSecurity6Choice.Code),nameof(FormOfSecurity6Choice.Code))]
    [JsonDerivedType(typeof(FormOfSecurity6Choice.Proprietary),nameof(FormOfSecurity6Choice.Proprietary))]
    [IsoId("_MBPGgTm-EeWV5sr121Fc8A")]
    [DisplayName("Form Of Security 6 Choice")]
    public abstract partial record FormOfSecurity6Choice_
    {
    }
}
