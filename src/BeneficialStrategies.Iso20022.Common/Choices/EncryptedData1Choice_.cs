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
    /// Choice between binary and hexadicimal binary for encrypted data of the transaction.
    /// </summary>
    [KnownType(typeof(EncryptedData1Choice.BinaryData))]
    [KnownType(typeof(EncryptedData1Choice.HexadecimalBinaryValue))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EncryptedData1Choice.BinaryData),nameof(EncryptedData1Choice.BinaryData))]
    [JsonDerivedType(typeof(EncryptedData1Choice.HexadecimalBinaryValue),nameof(EncryptedData1Choice.HexadecimalBinaryValue))]
    #endif
    [IsoId("_-on80-kLEemeDPHh-U9b6w")]
    [DisplayName("Encrypted Data 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EncryptedData1Choice_
    #else
    public abstract partial class EncryptedData1Choice_
    #endif
    {
    }
}
