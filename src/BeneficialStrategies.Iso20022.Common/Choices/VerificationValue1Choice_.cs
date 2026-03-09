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
    /// Contains the data to be authenticated or verified.
    /// </summary>
    [KnownType(typeof(VerificationValue1Choice.TextValue))]
    [KnownType(typeof(VerificationValue1Choice.BinaryValue))]
    [KnownType(typeof(VerificationValue1Choice.HexadecimalBinaryValue))]
    [KnownType(typeof(VerificationValue1Choice.PINData))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(VerificationValue1Choice.TextValue),nameof(VerificationValue1Choice.TextValue))]
    [JsonDerivedType(typeof(VerificationValue1Choice.BinaryValue),nameof(VerificationValue1Choice.BinaryValue))]
    [JsonDerivedType(typeof(VerificationValue1Choice.HexadecimalBinaryValue),nameof(VerificationValue1Choice.HexadecimalBinaryValue))]
    [JsonDerivedType(typeof(VerificationValue1Choice.PINData),nameof(VerificationValue1Choice.PINData))]
    #endif
    [IsoId("_4EhKpZaNEemfCcEf5rVTyg")]
    [DisplayName("Verification Value 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record VerificationValue1Choice_
    #else
    public abstract partial class VerificationValue1Choice_
    #endif
    {
    }
}
