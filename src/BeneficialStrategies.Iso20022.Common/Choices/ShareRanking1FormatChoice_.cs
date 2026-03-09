// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the share ranking.
    /// </summary>
    [KnownType(typeof(ShareRanking1FormatChoice.Code))]
    [KnownType(typeof(ShareRanking1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ShareRanking1FormatChoice.Code),nameof(ShareRanking1FormatChoice.Code))]
    [JsonDerivedType(typeof(ShareRanking1FormatChoice.Proprietary),nameof(ShareRanking1FormatChoice.Proprietary))]
    #endif
    [IsoId("_Ro8Rw9p-Ed-ak6NoX_4Aeg_1933759381")]
    [DisplayName("Share Ranking 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ShareRanking1FormatChoice_
    #else
    public abstract partial class ShareRanking1FormatChoice_
    #endif
    {
    }
}
