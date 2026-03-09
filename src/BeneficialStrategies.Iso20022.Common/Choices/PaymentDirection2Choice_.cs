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
    /// Choice of format for the payment direction.
    /// </summary>
    [KnownType(typeof(PaymentDirection2Choice.Indicator))]
    [KnownType(typeof(PaymentDirection2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentDirection2Choice.Indicator),nameof(PaymentDirection2Choice.Indicator))]
    [JsonDerivedType(typeof(PaymentDirection2Choice.Proprietary),nameof(PaymentDirection2Choice.Proprietary))]
    #endif
    [IsoId("_Qu-j5tp-Ed-ak6NoX_4Aeg_1993902591")]
    [DisplayName("Payment Direction 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentDirection2Choice_
    #else
    public abstract partial class PaymentDirection2Choice_
    #endif
    {
    }
}
