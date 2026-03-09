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
/// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
/// </summary>
[IsoId("_QOo28dp-Ed-ak6NoX_4Aeg_-2063318861")]
[DisplayName("Intermediary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Intermediary13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Intermediary13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Intermediary13( PartyIdentification4Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_QOo28tp-Ed-ak6NoX_4Aeg_-2063318809")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification4Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification4Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification4Choice_ Identification { get; init; } 
    #else
    public PartyIdentification4Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QOo289p-Ed-ak6NoX_4Aeg_-2063318388")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account2? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account2? Account { get; init; } 
    #else
    public Account2? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
    /// </summary>
    [IsoId("_QOo29Np-Ed-ak6NoX_4Aeg_-2063318328")]
    [DisplayName("Waived Trailer Commission Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WvdTrlrComssnInd")]
    #endif
    [IsoXmlTag("WvdTrlrComssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? WaivedTrailerCommissionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WaivedTrailerCommissionIndicator { get; init; } 
    #else
    public System.String? WaivedTrailerCommissionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Role or function performed by an intermediary in a given situation.
    /// </summary>
    [IsoId("_QOo29dp-Ed-ak6NoX_4Aeg_-2063318251")]
    [DisplayName("Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Role")]
    #endif
    [IsoXmlTag("Role")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundRole3Code? Role { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundRole3Code? Role { get; init; } 
    #else
    public InvestmentFundRole3Code? Role { get; set; } 
    #endif
    
    /// <summary>
    /// Role or function performed by an intermediary in a given situation.
    /// </summary>
    [IsoId("_QOo29tp-Ed-ak6NoX_4Aeg_-2063318148")]
    [DisplayName("Extended Role")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedRole")]
    #endif
    [IsoXmlTag("XtndedRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExtended350Code? ExtendedRole { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExtendedRole { get; init; } 
    #else
    public System.String? ExtendedRole { get; set; } 
    #endif
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QOo299p-Ed-ak6NoX_4Aeg_-2063317356")]
    [DisplayName("Primary Communication Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryComAdr")]
    #endif
    [IsoXmlTag("PmryComAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    #else
    public CommunicationAddress3? PrimaryCommunicationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QOo2-Np-Ed-ak6NoX_4Aeg_-2063317261")]
    [DisplayName("Secondary Communication Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryComAdr")]
    #endif
    [IsoXmlTag("ScndryComAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    #else
    public CommunicationAddress3? SecondaryCommunicationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_QOyn8Np-Ed-ak6NoX_4Aeg_-2063316930")]
    [DisplayName("Name And Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmAndAdr")]
    #endif
    [IsoXmlTag("NmAndAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress4? NameAndAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress4? NameAndAddress { get; init; } 
    #else
    public NameAndAddress4? NameAndAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
