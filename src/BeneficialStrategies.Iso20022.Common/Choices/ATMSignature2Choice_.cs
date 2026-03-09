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
    /// Element containing the signature.
    /// </summary>
    [KnownType(typeof(ATMSignature2Choice.DigitalSignature))]
    [KnownType(typeof(ATMSignature2Choice.TRRelatedData))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ATMSignature2Choice.DigitalSignature),nameof(ATMSignature2Choice.DigitalSignature))]
    [JsonDerivedType(typeof(ATMSignature2Choice.TRRelatedData),nameof(ATMSignature2Choice.TRRelatedData))]
    #endif
    [IsoId("_h8fS4bTwEeeQy4o2AayYHg")]
    [DisplayName("ATM Signature 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ATMSignature2Choice_
    #else
    public abstract partial class ATMSignature2Choice_
    #endif
    {
    }
}
