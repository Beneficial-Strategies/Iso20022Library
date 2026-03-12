// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References40Choice.RelatedReference))]
    [KnownType(typeof(References40Choice.OtherReference))]
    [JsonDerivedType(typeof(References40Choice.RelatedReference),nameof(References40Choice.RelatedReference))]
    [JsonDerivedType(typeof(References40Choice.OtherReference),nameof(References40Choice.OtherReference))]
    [IsoId("_SRMKUSGiEeONGJioFgcMDw")]
    [DisplayName("References 40 Choice")]
    public abstract partial record References40Choice_
    {
    }
}
