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
/// Contains elements identifying an event belonging to the transaction.
/// </summary>
[IsoId("_TsN2cKJoEeaLbOzg6lYrCA")]
[DisplayName("Payment Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentEvent2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentEvent2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentEvent2( System.String reqFrom,System.String reqTo,System.String reqReceived )
    {
        From = reqFrom;
        To = reqTo;
        Received = reqReceived;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the sending MessagingEndpoint that has created this business message for the receiving MessagingEndpoint that will process this business message.
    /// Usage:
    /// the sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_hqnrAqJoEeaLbOzg6lYrCA")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier From { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String From { get; init; } 
    #else
    public System.String From { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this business message.
    /// Usage:
    /// the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_hqoSEKJoEeaLbOzg6lYrCA")]
    [DisplayName("To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="To")]
    #endif
    [IsoXmlTag("To")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier To { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String To { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String To { get; init; } 
    #else
    public System.String To { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a payment has been received or not. 
    /// </summary>
    [IsoId("_wvnewKJpEeaLbOzg6lYrCA")]
    [DisplayName("Received")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcvd")]
    #endif
    [IsoXmlTag("Rcvd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Received { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Received { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Received { get; init; } 
    #else
    public System.String Received { get; set; } 
    #endif
    
    
    #nullable disable
    
}
