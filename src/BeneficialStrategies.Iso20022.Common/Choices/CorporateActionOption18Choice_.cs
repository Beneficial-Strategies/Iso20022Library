// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the type of corporate action options.
    /// </summary>
    [KnownType(typeof(CorporateActionOption18Choice.Code))]
    [KnownType(typeof(CorporateActionOption18Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionOption18Choice.Code),nameof(CorporateActionOption18Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionOption18Choice.Proprietary),nameof(CorporateActionOption18Choice.Proprietary))]
    [IsoId("_eSyW0UEHEeWVgfuHGaKtRQ")]
    [DisplayName("Corporate Action Option 18 Choice")]
    public abstract partial record CorporateActionOption18Choice_
    {
    }
}
