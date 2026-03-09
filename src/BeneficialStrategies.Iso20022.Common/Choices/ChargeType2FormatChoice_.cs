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
    /// Choice between a standard code or a proprietary code for specifying the type of charge.
    /// </summary>
    [KnownType(typeof(ChargeType2FormatChoice.Code))]
    [KnownType(typeof(ChargeType2FormatChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargeType2FormatChoice.Code),nameof(ChargeType2FormatChoice.Code))]
    [JsonDerivedType(typeof(ChargeType2FormatChoice.Proprietary),nameof(ChargeType2FormatChoice.Proprietary))]
    #endif
    [IsoId("_Rl0FRNp-Ed-ak6NoX_4Aeg_-1615660129")]
    [DisplayName("Charge Type 2 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargeType2FormatChoice_
    #else
    public abstract partial class ChargeType2FormatChoice_
    #endif
    {
    }
}
