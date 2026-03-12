// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
[IsoId("_npOisWAXEeiH9-hkDDXUHA")]
[DisplayName("Cheque")]
public partial record Cheque10
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the cheque as assigned by the financial institution.
    /// </summary>
    [IsoId("_n8akcWAXEeiH9-hkDDXUHA")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; } 
    
    /// <summary>
    /// Party to which the cheque is made payable.
    /// </summary>
    [IsoId("_n8akc2AXEeiH9-hkDDXUHA")]
    [DisplayName("Payee Identification")]
    [IsoXmlTag("PyeeId")]
    public required PartyIdentification139 PayeeIdentification { get; init; } 
    
    /// <summary>
    /// Financial institution on which the cheque is drawn, that is, the financial institution that services the account of the entity that issued the cheque.
    /// </summary>
    [IsoId("_n8kVcGAXEeiH9-hkDDXUHA")]
    [DisplayName("Drawee Identification")]
    [IsoXmlTag("DrweeId")]
    public FinancialInstitutionIdentification17? DraweeIdentification { get; init; } 
    
    /// <summary>
    /// Account owner that issues the cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
    /// </summary>
    [IsoId("_n8kVcmAXEeiH9-hkDDXUHA")]
    [DisplayName("Drawer Identification")]
    [IsoXmlTag("DrwrId")]
    public PartyIdentification139? DrawerIdentification { get; init; } 
    
    
    #nullable disable
    
}
