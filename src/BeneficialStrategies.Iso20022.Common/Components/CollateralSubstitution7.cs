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
/// Provides details about the collateral that will be substituted.
/// </summary>
[IsoId("_UpuLTSqSEeyR9JrVGfaMKw")]
[DisplayName("Collateral Substitution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralSubstitution7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralSubstitution7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralSubstitution7( CollateralSubstitutionSequence1Code reqCollateralSubstitutionSequence,ActiveCurrencyAndAmount reqSubstitutionRequirement,CollateralSubstitutionType1Code reqCollateralSubstitutionType )
    {
        CollateralSubstitutionSequence = reqCollateralSubstitutionSequence;
        SubstitutionRequirement = reqSubstitutionRequirement;
        CollateralSubstitutionType = reqCollateralSubstitutionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the collateral substitution request is new or updated.
    /// </summary>
    [IsoId("_VBkDgyqSEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Substitution Sequence")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSbstitnSeq")]
    #endif
    [IsoXmlTag("CollSbstitnSeq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralSubstitutionSequence1Code CollateralSubstitutionSequence { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralSubstitutionSequence1Code CollateralSubstitutionSequence { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralSubstitutionSequence1Code CollateralSubstitutionSequence { get; init; } 
    #else
    public CollateralSubstitutionSequence1Code CollateralSubstitutionSequence { get; set; } 
    #endif
    
    /// <summary>
    /// Cash value of the requested collateral substitution transfer in the base currency.
    /// </summary>
    [IsoId("_VBkDhSqSEeyR9JrVGfaMKw")]
    [DisplayName("Substitution Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbstitnRqrmnt")]
    #endif
    [IsoXmlTag("SbstitnRqrmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount SubstitutionRequirement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount SubstitutionRequirement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount SubstitutionRequirement { get; init; } 
    #else
    public ActiveCurrencyAndAmount SubstitutionRequirement { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the collateral that is substituted was posted against the variation margin or the independent amount.
    /// </summary>
    [IsoId("_VBkDhyqSEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Substitution Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSbstitnTp")]
    #endif
    [IsoXmlTag("CollSbstitnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralSubstitutionType1Code CollateralSubstitutionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralSubstitutionType1Code CollateralSubstitutionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralSubstitutionType1Code CollateralSubstitutionType { get; init; } 
    #else
    public CollateralSubstitutionType1Code CollateralSubstitutionType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    [IsoId("_VBkDiSqSEeyR9JrVGfaMKw")]
    [DisplayName("Standard Settlement Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StdSttlmInstrs")]
    #endif
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StandardSettlementInstructions { get; init; } 
    #else
    public System.String? StandardSettlementInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    [IsoId("_VBkDiyqSEeyR9JrVGfaMKw")]
    [DisplayName("Securities Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesColl")]
    #endif
    [IsoXmlTag("SctiesColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesCollateral11? SecuritiesCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesCollateral11? SecuritiesCollateral { get; init; } 
    #else
    public SecuritiesCollateral11? SecuritiesCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    [IsoId("_VBkDjSqSEeyR9JrVGfaMKw")]
    [DisplayName("Cash Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshColl")]
    #endif
    [IsoXmlTag("CshColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashCollateral5? CashCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashCollateral5? CashCollateral { get; init; } 
    #else
    public CashCollateral5? CashCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    [IsoId("_VBkDjyqSEeyR9JrVGfaMKw")]
    [DisplayName("Other Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrColl")]
    #endif
    [IsoXmlTag("OthrColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherCollateral11? OtherCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherCollateral11? OtherCollateral { get; init; } 
    #else
    public OtherCollateral11? OtherCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the identification of previously sent and/or received message(s), in case of updated substitution request.
    /// </summary>
    [IsoId("_VBkDkSqSEeyR9JrVGfaMKw")]
    [DisplayName("Linked References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdRefs")]
    #endif
    [IsoXmlTag("LkdRefs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reference17? LinkedReferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reference17? LinkedReferences { get; init; } 
    #else
    public Reference17? LinkedReferences { get; set; } 
    #endif
    
    
    #nullable disable
    
}
