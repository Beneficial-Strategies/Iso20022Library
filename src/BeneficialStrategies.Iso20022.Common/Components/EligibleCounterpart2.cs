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
/// Represents a party to be identified as eligible for the instructing party.
/// </summary>
[IsoId("_jzsckeLXEeWFtOV72FbX9w")]
[DisplayName("Eligible Counterpart")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EligibleCounterpart2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EligibleCounterpart2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EligibleCounterpart2( SystemPartyIdentification1Choice_ reqIssuerIdentification,SystemPartyIdentification1Choice_ reqEligibleCounterpartIdentification,System.DateOnly reqValidFrom,EligibilityType1Code reqEligibilityType,EligibilityIdentification2Choice_ reqEligibilityIdentification )
    {
        IssuerIdentification = reqIssuerIdentification;
        EligibleCounterpartIdentification = reqEligibleCounterpartIdentification;
        ValidFrom = reqValidFrom;
        EligibilityType = reqEligibilityType;
        EligibilityIdentification = reqEligibilityIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique business identifier code used to identify the party providing the eligible counterpart information.
    /// </summary>
    [IsoId("_j_JeoeLXEeWFtOV72FbX9w")]
    [DisplayName("Issuer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrId")]
    #endif
    [IsoXmlTag("IssrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification1Choice_ IssuerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyIdentification1Choice_ IssuerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification1Choice_ IssuerIdentification { get; init; } 
    #else
    public SystemPartyIdentification1Choice_ IssuerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique business identifier code used to identify the central securities depository to be defined as eligible.
    /// </summary>
    [IsoId("_j_Jeo-LXEeWFtOV72FbX9w")]
    [DisplayName("Eligible Counterpart Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgblCntrptId")]
    #endif
    [IsoXmlTag("ElgblCntrptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemPartyIdentification1Choice_ EligibleCounterpartIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemPartyIdentification1Choice_ EligibleCounterpartIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemPartyIdentification1Choice_ EligibleCounterpartIdentification { get; init; } 
    #else
    public SystemPartyIdentification1Choice_ EligibleCounterpartIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date from when the eligible counterpart is valid.
    /// </summary>
    [IsoId("_j_JepeLXEeWFtOV72FbX9w")]
    [DisplayName("Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldFr")]
    #endif
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValidFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValidFrom { get; init; } 
    #else
    public System.DateOnly ValidFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Date until when the eligible counterpart is valid.
    /// </summary>
    [IsoId("_j_Jep-LXEeWFtOV72FbX9w")]
    [DisplayName("Valid To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldTo")]
    #endif
    [IsoXmlTag("VldTo")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValidTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValidTo { get; init; } 
    #else
    public System.DateOnly? ValidTo { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the type of eligibility.
    /// </summary>
    [IsoId("_j_JeqeLXEeWFtOV72FbX9w")]
    [DisplayName("Eligibility Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgbltyTp")]
    #endif
    [IsoXmlTag("ElgbltyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EligibilityType1Code EligibilityType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EligibilityType1Code EligibilityType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EligibilityType1Code EligibilityType { get; init; } 
    #else
    public EligibilityType1Code EligibilityType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the eligible counterpart party.
    /// </summary>
    [IsoId("_j_Jeq-LXEeWFtOV72FbX9w")]
    [DisplayName("Eligibility Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgbltyId")]
    #endif
    [IsoXmlTag("ElgbltyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EligibilityIdentification2Choice_ EligibilityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EligibilityIdentification2Choice_ EligibilityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EligibilityIdentification2Choice_ EligibilityIdentification { get; init; } 
    #else
    public EligibilityIdentification2Choice_ EligibilityIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
