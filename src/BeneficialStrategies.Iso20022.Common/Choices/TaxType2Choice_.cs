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
    /// Specifies the type of tax as a code or free text.
    /// </summary>
    [KnownType(typeof(TaxType2Choice.Type))]
    [KnownType(typeof(TaxType2Choice.OtherTaxType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxType2Choice.Type),nameof(TaxType2Choice.Type))]
    [JsonDerivedType(typeof(TaxType2Choice.OtherTaxType),nameof(TaxType2Choice.OtherTaxType))]
    #endif
    [IsoId("_Xf3zQBrfEeOVR9VN6fAMUg")]
    [DisplayName("Tax Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxType2Choice_
    #else
    public abstract partial class TaxType2Choice_
    #endif
    {
    }
}
