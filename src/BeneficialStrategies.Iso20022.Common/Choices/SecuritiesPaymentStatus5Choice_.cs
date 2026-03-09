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
    [KnownType(typeof(SecuritiesPaymentStatus5Choice.Code))]
    [KnownType(typeof(SecuritiesPaymentStatus5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesPaymentStatus5Choice.Code),nameof(SecuritiesPaymentStatus5Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesPaymentStatus5Choice.Proprietary),nameof(SecuritiesPaymentStatus5Choice.Proprietary))]
    #endif
    [IsoId("_cBDuUTnAEeWV5sr121Fc8A")]
    [DisplayName("Securities Payment Status 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesPaymentStatus5Choice_
    #else
    public abstract partial class SecuritiesPaymentStatus5Choice_
    #endif
    {
    }
}
