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
/// Provides securities proceeds information.
/// </summary>
[IsoId("_UK6fR9p-Ed-ak6NoX_4Aeg_1911486700")]
[DisplayName("Securities Proceeds")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesProceeds1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesProceeds1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesProceeds1( SecurityIdentification7 reqSecurityIdentification,UnitOrFaceAmount1Choice_ reqPostingQuantity )
    {
        SecurityIdentification = reqSecurityIdentification;
        PostingQuantity = reqPostingQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UK6fSNp-Ed-ak6NoX_4Aeg_-1868154085")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification7 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification7 SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// The quantity of financial instruments that is posted.
    /// </summary>
    [IsoId("_UK6fSdp-Ed-ak6NoX_4Aeg_-1868154084")]
    [DisplayName("Posting Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstngQty")]
    #endif
    [IsoXmlTag("PstngQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ PostingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmount1Choice_ PostingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ PostingQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ PostingQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the account that is debited/credited.
    /// </summary>
    [IsoId("_UK6fStp-Ed-ak6NoX_4Aeg_-1386075125")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<SecuritiesAccount10> AccountDetails { get; init; } = new ValueList<SecuritiesAccount10>(){};
    
    /// <summary>
    /// Provides reconciliation information.
    /// </summary>
    [IsoId("_UK6fS9p-Ed-ak6NoX_4Aeg_1005212096")]
    [DisplayName("Reconciliation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnDtls")]
    #endif
    [IsoXmlTag("RcncltnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ReconciliationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReconciliationDetails { get; init; } 
    #else
    public System.String? ReconciliationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
