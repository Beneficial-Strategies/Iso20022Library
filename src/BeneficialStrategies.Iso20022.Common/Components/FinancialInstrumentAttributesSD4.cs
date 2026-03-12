// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding security that will being distributed as part of entitlement.
/// </summary>
[IsoId("_1gx98jL3EeKU9IrkkToqcw_762356637")]
[DisplayName("Financial Instrument Attributes SD")]
public partial record FinancialInstrumentAttributesSD4
{
    #nullable enable
    
    /// <summary>
    /// Security identification that a CSD (for example in the US - DTC, The Depository Trust Corporation) will distribute as part of the entitlement. This can be the DTC contra CUSIP in cases where the payout security is a contra CUSIP.
    /// </summary>
    [IsoId("_1gx98zL3EeKU9IrkkToqcw_-234715716")]
    [DisplayName("CSD Disbursed Security Identification")]
    [IsoXmlTag("CSDDsbrsdSctyId")]
    public SecurityIdentification15? CSDDisbursedSecurityIdentification { get; init; } 
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) disbursed security description.
    /// </summary>
    [IsoId("_1gx99DL3EeKU9IrkkToqcw_-1345627135")]
    [DisplayName("CSD Disbursed Security Description")]
    [IsoXmlTag("CSDDsbrsdSctyDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? CSDDisbursedSecurityDescription { get; init; } 
    
    /// <summary>
    /// Security identification of the security that will be distributed in fractions by the CSD (for example in the US - DTC, The Depository Trust Corporation) DTC (The Depository Trust Corporation) as a result of a corporate action.
    /// </summary>
    [IsoId("_1g7u8DL3EeKU9IrkkToqcw_1409282724")]
    [DisplayName("CSD Disbursed Fractional Security Identification")]
    [IsoXmlTag("CSDDsbrsdFrctnlSctyId")]
    public SecurityIdentification15? CSDDisbursedFractionalSecurityIdentification { get; init; } 
    
    
    #nullable disable
    
}
