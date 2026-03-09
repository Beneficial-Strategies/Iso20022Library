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
    /// Choice of formats to express the effect on the holdings of electing a Corporate Action option.
    /// </summary>
    [KnownType(typeof(ElectionMovementType1FormatChoice.Code))]
    [KnownType(typeof(ElectionMovementType1FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ElectionMovementType1FormatChoice.Code),nameof(ElectionMovementType1FormatChoice.Code))]
    [JsonDerivedType(typeof(ElectionMovementType1FormatChoice.Proprietary),nameof(ElectionMovementType1FormatChoice.Proprietary))]
    #endif
    [IsoId("_RmZ7KNp-Ed-ak6NoX_4Aeg_-162374366")]
    [DisplayName("Election Movement Type 1 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ElectionMovementType1FormatChoice_
    #else
    public abstract partial class ElectionMovementType1FormatChoice_
    #endif
    {
    }
}
