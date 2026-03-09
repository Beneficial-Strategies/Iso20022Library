// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("_PyBzd9p-Ed-ak6NoX_4Aeg_194999115")]
[DisplayName("Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer or investment account.
    /// </summary>
    [IsoId("_PyLkcNp-Ed-ak6NoX_4Aeg_194999578")]
    [DisplayName("Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrm")]
    #endif
    [IsoXmlTag("PmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument11Choice_? PaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument11Choice_? PaymentInstrument { get; init; } 
    #else
    public PaymentInstrument11Choice_? PaymentInstrument { get; set; } 
    #endif
    
    
    #nullable disable
    
}
