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
    /// Specifies the type of charges as a code or free text.
    /// </summary>
    [KnownType(typeof(ChargesType1Choice.Type))]
    [KnownType(typeof(ChargesType1Choice.OtherChargesType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ChargesType1Choice.Type),nameof(ChargesType1Choice.Type))]
    [JsonDerivedType(typeof(ChargesType1Choice.OtherChargesType),nameof(ChargesType1Choice.OtherChargesType))]
    #endif
    [IsoId("_nKgLABrdEeOVR9VN6fAMUg")]
    [DisplayName("Charges Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ChargesType1Choice_
    #else
    public abstract partial class ChargesType1Choice_
    #endif
    {
    }
}
