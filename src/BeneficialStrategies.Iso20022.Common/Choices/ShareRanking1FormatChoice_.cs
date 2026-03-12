// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the share ranking.
    /// </summary>
    [KnownType(typeof(ShareRanking1FormatChoice.Code))]
    [KnownType(typeof(ShareRanking1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(ShareRanking1FormatChoice.Code),nameof(ShareRanking1FormatChoice.Code))]
    [JsonDerivedType(typeof(ShareRanking1FormatChoice.Proprietary),nameof(ShareRanking1FormatChoice.Proprietary))]
    [IsoId("_Ro8Rw9p-Ed-ak6NoX_4Aeg_1933759381")]
    [DisplayName("Share Ranking 1 Format Choice")]
    public abstract partial record ShareRanking1FormatChoice_
    {
    }
}
