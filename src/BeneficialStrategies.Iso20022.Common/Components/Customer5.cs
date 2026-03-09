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
/// Details of the customer
/// </summary>
[IsoId("_Uany0vPmEeihCvvpsmGI2w")]
[DisplayName("Customer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Customer5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Customer5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Customer5( PartyIdentification208 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the customer.
    /// </summary>
    [IsoId("_UapA6fPmEeihCvvpsmGI2w")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the party identification.
    /// </summary>
    [IsoId("_UapA5PPmEeihCvvpsmGI2w")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification208 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification208 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification208 Identification { get; init; } 
    #else
    public PartyIdentification208 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Number or code assigned by an airline, company or other party to track or uniquely identify a person, department or project.
    /// </summary>
    [IsoId("_JALdkP5LEei6wbTV6LEt-g")]
    [DisplayName("Customer File Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrFileRefNb")]
    #endif
    [IsoXmlTag("CstmrFileRefNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CustomerFileReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerFileReferenceNumber { get; init; } 
    #else
    public System.String? CustomerFileReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Age of the customer.
    /// </summary>
    [IsoId("_UapA5vPmEeihCvvpsmGI2w")]
    [DisplayName("Age")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Age")]
    #endif
    [IsoXmlTag("Age")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? Age { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Age { get; init; } 
    #else
    public System.String? Age { get; set; } 
    #endif
    
    /// <summary>
    /// Address details of the customer.
    /// </summary>
    [IsoId("_UapA7vPmEeihCvvpsmGI2w")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address1? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address1? Address { get; init; } 
    #else
    public Address1? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    [IsoId("_UapA6PPmEeihCvvpsmGI2w")]
    [DisplayName("Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctct")]
    #endif
    [IsoXmlTag("Ctct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact6? Contact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact6? Contact { get; init; } 
    #else
    public Contact6? Contact { get; set; } 
    #endif
    
    
    #nullable disable
    
}
