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
/// Specifies a frequency, format and delivery address for statements.
/// </summary>
[IsoId("_Xr9A8A1gEeKGXqvMN6jpiw")]
[DisplayName("Statement Frequency And Form")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatementFrequencyAndForm1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatementFrequencyAndForm1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatementFrequencyAndForm1( Frequency7Code reqFrequency,CommunicationMethod2Choice_ reqCommunicationMethod,System.String reqDeliveryAddress,CommunicationFormat1Choice_ reqFormat )
    {
        Frequency = reqFrequency;
        CommunicationMethod = reqCommunicationMethod;
        DeliveryAddress = reqDeliveryAddress;
        Format = reqFormat;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the frequency for sending statements.
    /// </summary>
    [IsoId("_ip_b0A1gEeKGXqvMN6jpiw")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency7Code Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency7Code Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency7Code Frequency { get; init; } 
    #else
    public Frequency7Code Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the communication method for statements.
    /// </summary>
    [IsoId("_v6zxoA1gEeKGXqvMN6jpiw")]
    [DisplayName("Communication Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComMtd")]
    #endif
    [IsoXmlTag("ComMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommunicationMethod2Choice_ CommunicationMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommunicationMethod2Choice_ CommunicationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationMethod2Choice_ CommunicationMethod { get; init; } 
    #else
    public CommunicationMethod2Choice_ CommunicationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the delivery address for statements.
    /// </summary>
    [IsoId("_5MpwcA1gEeKGXqvMN6jpiw")]
    [DisplayName("Delivery Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryAdr")]
    #endif
    [IsoXmlTag("DlvryAdr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text DeliveryAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DeliveryAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DeliveryAddress { get; init; } 
    #else
    public System.String DeliveryAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the format for statements.
    /// </summary>
    [IsoId("__ID-8A1gEeKGXqvMN6jpiw")]
    [DisplayName("Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frmt")]
    #endif
    [IsoXmlTag("Frmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommunicationFormat1Choice_ Format { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommunicationFormat1Choice_ Format { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationFormat1Choice_ Format { get; init; } 
    #else
    public CommunicationFormat1Choice_ Format { get; set; } 
    #endif
    
    
    #nullable disable
    
}
