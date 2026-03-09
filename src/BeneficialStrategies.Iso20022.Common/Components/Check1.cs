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
/// Identification of check as payment instrument.
/// </summary>
[IsoId("_grZ50NkJEeiojJsa6FYyew")]
[DisplayName("Check")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Check1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the institution (bank) issuing the check.
    /// </summary>
    [IsoId("_wrMXUNkJEeiojJsa6FYyew")]
    [DisplayName("Bank Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkId")]
    #endif
    [IsoXmlTag("BkId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BankIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BankIdentification { get; init; } 
    #else
    public System.String? BankIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the account linked to the check.
    /// </summary>
    [IsoId("_qyELUNkKEeiojJsa6FYyew")]
    [DisplayName("Account Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctNb")]
    #endif
    [IsoXmlTag("AcctNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountNumber { get; init; } 
    #else
    public System.String? AccountNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the check.
    /// </summary>
    [IsoId("_0LCs4NkKEeiojJsa6FYyew")]
    [DisplayName("Check Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckNb")]
    #endif
    [IsoXmlTag("ChckNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CheckNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CheckNumber { get; init; } 
    #else
    public System.String? CheckNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Check guarantee card number.
    /// The human readable number from the Check Guarantee Card that is presented during the check tendering process.
    /// </summary>
    [IsoId("_Aq0nUNkLEeiojJsa6FYyew")]
    [DisplayName("Check Card Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckCardNb")]
    #endif
    [IsoXmlTag("ChckCardNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CheckCardNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CheckCardNumber { get; init; } 
    #else
    public System.String? CheckCardNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Track Data of the check to digitally identify the data.
    /// </summary>
    [IsoId("_AS8dYNkMEeiojJsa6FYyew")]
    [DisplayName("Check Track Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckTrckData2")]
    #endif
    [IsoXmlTag("ChckTrckData2")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackData2? CheckTrackData2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackData2? CheckTrackData2 { get; init; } 
    #else
    public TrackData2? CheckTrackData2 { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the check (personal or professional).
    /// </summary>
    [IsoId("_DJ9mQNtbEeipuvJHTHIw9A")]
    [DisplayName("Check Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChckTp")]
    #endif
    [IsoXmlTag("ChckTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CheckType1Code? CheckType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CheckType1Code? CheckType { get; init; } 
    #else
    public CheckType1Code? CheckType { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the check.
    /// </summary>
    [IsoId("_H-b-4NkLEeiojJsa6FYyew")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Text? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Country { get; init; } 
    #else
    public System.String? Country { get; set; } 
    #endif
    
    
    #nullable disable
    
}
