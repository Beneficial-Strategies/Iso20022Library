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
    /// Choice of formats for the signature type.
    /// </summary>
    [KnownType(typeof(SignatureType1Choice.Code))]
    [KnownType(typeof(SignatureType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SignatureType1Choice.Code),nameof(SignatureType1Choice.Code))]
    [JsonDerivedType(typeof(SignatureType1Choice.Proprietary),nameof(SignatureType1Choice.Proprietary))]
    #endif
    [IsoId("_k8doQDoHEeabspMEjqY5TQ")]
    [DisplayName("Signature Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SignatureType1Choice_
    #else
    public abstract partial class SignatureType1Choice_
    #endif
    {
    }
}
