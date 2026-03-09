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
[IsoId("_6GsLuTbsEead9bDRE_1DAQ")]
[DisplayName("Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction72
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransaction72 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransaction72( PaymentInstrument21Choice_ reqPaymentInstrument )
    {
        PaymentInstrument = reqPaymentInstrument;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Choice between types of payment instrument, for example, cheque, credit transfer or investment account.
    /// </summary>
    [IsoId("_6fPOdTbsEead9bDRE_1DAQ")]
    [DisplayName("Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrm")]
    #endif
    [IsoXmlTag("PmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentInstrument21Choice_ PaymentInstrument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentInstrument21Choice_ PaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument21Choice_ PaymentInstrument { get; init; } 
    #else
    public PaymentInstrument21Choice_ PaymentInstrument { get; set; } 
    #endif
    
    
    #nullable disable
    
}
