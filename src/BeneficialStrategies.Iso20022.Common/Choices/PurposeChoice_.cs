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
    /// Underlying reason for the payment transaction, eg, a charity payment, or a commercial agreement between the creditor and the debtor.
    /// </summary>
    [KnownType(typeof(PurposeChoice.Proprietary))]
    [KnownType(typeof(PurposeChoice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PurposeChoice.Proprietary),nameof(PurposeChoice.Proprietary))]
    [JsonDerivedType(typeof(PurposeChoice.Code),nameof(PurposeChoice.Code))]
    #endif
    [IsoId("_Rbhg1dp-Ed-ak6NoX_4Aeg_1321046879")]
    [DisplayName("Purpose Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PurposeChoice_
    #else
    public abstract partial class PurposeChoice_
    #endif
    {
    }
}
