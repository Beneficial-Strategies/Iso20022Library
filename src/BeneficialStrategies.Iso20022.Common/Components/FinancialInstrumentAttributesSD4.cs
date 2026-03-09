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
/// Provides additional information regarding security that will being distributed as part of entitlement.
/// </summary>
[IsoId("_1gx98jL3EeKU9IrkkToqcw_762356637")]
[DisplayName("Financial Instrument Attributes SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributesSD4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Security identification that a CSD (for example in the US - DTC, The Depository Trust Corporation) will distribute as part of the entitlement. This can be the DTC contra CUSIP in cases where the payout security is a contra CUSIP.
    /// </summary>
    [IsoId("_1gx98zL3EeKU9IrkkToqcw_-234715716")]
    [DisplayName("CSD Disbursed Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSDDsbrsdSctyId")]
    #endif
    [IsoXmlTag("CSDDsbrsdSctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification15? CSDDisbursedSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification15? CSDDisbursedSecurityIdentification { get; init; } 
    #else
    public SecurityIdentification15? CSDDisbursedSecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) disbursed security description.
    /// </summary>
    [IsoId("_1gx99DL3EeKU9IrkkToqcw_-1345627135")]
    [DisplayName("CSD Disbursed Security Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSDDsbrsdSctyDesc")]
    #endif
    [IsoXmlTag("CSDDsbrsdSctyDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? CSDDisbursedSecurityDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CSDDisbursedSecurityDescription { get; init; } 
    #else
    public System.String? CSDDisbursedSecurityDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Security identification of the security that will be distributed in fractions by the CSD (for example in the US - DTC, The Depository Trust Corporation) DTC (The Depository Trust Corporation) as a result of a corporate action.
    /// </summary>
    [IsoId("_1g7u8DL3EeKU9IrkkToqcw_1409282724")]
    [DisplayName("CSD Disbursed Fractional Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CSDDsbrsdFrctnlSctyId")]
    #endif
    [IsoXmlTag("CSDDsbrsdFrctnlSctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification15? CSDDisbursedFractionalSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification15? CSDDisbursedFractionalSecurityIdentification { get; init; } 
    #else
    public SecurityIdentification15? CSDDisbursedFractionalSecurityIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
