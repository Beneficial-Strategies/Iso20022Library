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
/// Set of search criteria for querying party reference data.
/// </summary>
[IsoId("_5ry10Z9wEeejnerJgFeC2w")]
[DisplayName("Party Data Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyDataSearchCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the opening date of the party.
    /// </summary>
    [IsoId("_55esgZ9wEeejnerJgFeC2w")]
    [DisplayName("Opening Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngDt")]
    #endif
    [IsoXmlTag("OpngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriodSearch1Choice_? OpeningDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodSearch1Choice_? OpeningDate { get; init; } 
    #else
    public DatePeriodSearch1Choice_? OpeningDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the closing date of the party.
    /// </summary>
    [IsoId("_55esg59wEeejnerJgFeC2w")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriodSearch1Choice_? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodSearch1Choice_? ClosingDate { get; init; } 
    #else
    public DatePeriodSearch1Choice_? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type classification of the party.
    /// </summary>
    [IsoId("_55eshZ9wEeejnerJgFeC2w")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemPartyType1Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyType1Choice_? Type { get; init; } 
    #else
    public SystemPartyType1Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the party responsible for the maintenance of the party reference data.
    /// </summary>
    [IsoId("_PhqX0Ip_EeiEt5E1WBt_2Q")]
    [DisplayName("Responsible Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnsblPtyId")]
    #endif
    [IsoXmlTag("RspnsblPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    #else
    public PartyIdentification136? ResponsiblePartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_55esiZ9wEeejnerJgFeC2w")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification136? PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136? PartyIdentification { get; init; } 
    #else
    public PartyIdentification136? PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the identification of a restriction.
    /// </summary>
    [IsoId("_55esi59wEeejnerJgFeC2w")]
    [DisplayName("Restriction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctnId")]
    #endif
    [IsoXmlTag("RstrctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RestrictionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RestrictionIdentification { get; init; } 
    #else
    public System.String? RestrictionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date when the restriction for the party has been issued.
    /// </summary>
    [IsoId("_55esjZ9wEeejnerJgFeC2w")]
    [DisplayName("Restriction Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctnIsseDt")]
    #endif
    [IsoXmlTag("RstrctnIsseDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeSearch4Choice_? RestrictionIssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeSearch4Choice_? RestrictionIssueDate { get; init; } 
    #else
    public DateAndDateTimeSearch4Choice_? RestrictionIssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// </summary>
    [IsoId("_NhaAEowbEei289CGNqs21g")]
    [DisplayName("Residence Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ResTp")]
    #endif
    [IsoXmlTag("ResTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResidenceType1Code? ResidenceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResidenceType1Code? ResidenceType { get; init; } 
    #else
    public ResidenceType1Code? ResidenceType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the party is locked or not, and the reason for this status, when required.
    /// </summary>
    [IsoId("_NhaAE4wbEei289CGNqs21g")]
    [DisplayName("Lock Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LckSts")]
    #endif
    [IsoXmlTag("LckSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyLockStatus1? LockStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyLockStatus1? LockStatus { get; init; } 
    #else
    public PartyLockStatus1? LockStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
