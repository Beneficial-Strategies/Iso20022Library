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
    /// Choice of format for the status of payment of a security at a particular time.
    /// </summary>
    [KnownType(typeof(SecuritiesPaymentStatus6Choice.Code))]
    [KnownType(typeof(SecuritiesPaymentStatus6Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesPaymentStatus6Choice.Code),nameof(SecuritiesPaymentStatus6Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesPaymentStatus6Choice.Proprietary),nameof(SecuritiesPaymentStatus6Choice.Proprietary))]
    #endif
    [IsoId("_5NZ7p5NLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Payment Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesPaymentStatus6Choice_
    #else
    public abstract partial class SecuritiesPaymentStatus6Choice_
    #endif
    {
    }
}
