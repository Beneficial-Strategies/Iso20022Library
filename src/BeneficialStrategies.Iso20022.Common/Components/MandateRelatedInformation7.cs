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
/// Set of elements used to provide further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_TD1icdp-Ed-ak6NoX_4Aeg_621431627")]
[DisplayName("Mandate Related Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateRelatedInformation7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_TD1ictp-Ed-ak6NoX_4Aeg_-385375482")]
    [DisplayName("Mandate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtId")]
    #endif
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MandateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MandateIdentification { get; init; } 
    #else
    public System.String? MandateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_TD1ic9p-Ed-ak6NoX_4Aeg_2065722825")]
    [DisplayName("Date Of Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfSgntr")]
    #endif
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateOfSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateOfSignature { get; init; } 
    #else
    public System.DateOnly? DateOfSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    [IsoId("_TD1idNp-Ed-ak6NoX_4Aeg_-1786255979")]
    [DisplayName("Amendment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntInd")]
    #endif
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmendmentIndicator { get; init; } 
    #else
    public System.String? AmendmentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    [IsoId("_TD1iddp-Ed-ak6NoX_4Aeg_994649792")]
    [DisplayName("Amendment Information Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntInfDtls")]
    #endif
    [IsoXmlTag("AmdmntInfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmendmentInformationDetails7? AmendmentInformationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmendmentInformationDetails7? AmendmentInformationDetails { get; init; } 
    #else
    public AmendmentInformationDetails7? AmendmentInformationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    [IsoId("_TD1idtp-Ed-ak6NoX_4Aeg_1270618389")]
    [DisplayName("Electronic Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncSgntr")]
    #endif
    [IsoXmlTag("ElctrncSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? ElectronicSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ElectronicSignature { get; init; } 
    #else
    public System.String? ElectronicSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_TD1id9p-Ed-ak6NoX_4Aeg_1856565415")]
    [DisplayName("First Collection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstColltnDt")]
    #endif
    [IsoXmlTag("FrstColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FirstCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FirstCollectionDate { get; init; } 
    #else
    public System.DateOnly? FirstCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    [IsoId("_TD1ieNp-Ed-ak6NoX_4Aeg_-2113284374")]
    [DisplayName("Final Collection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlColltnDt")]
    #endif
    [IsoXmlTag("FnlColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FinalCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FinalCollectionDate { get; init; } 
    #else
    public System.DateOnly? FinalCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    [IsoId("_TD_TcNp-Ed-ak6NoX_4Aeg_466783695")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency1Code? Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency1Code? Frequency { get; init; } 
    #else
    public Frequency1Code? Frequency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
