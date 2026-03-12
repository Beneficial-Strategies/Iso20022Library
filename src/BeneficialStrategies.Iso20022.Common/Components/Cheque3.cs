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
[IsoId("_QbdK-9p-Ed-ak6NoX_4Aeg_-241775444")]
[DisplayName("Cheque")]
public partial record Cheque3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the financial institution.
    /// </summary>
    [IsoId("_QbdK_Np-Ed-ak6NoX_4Aeg_-241775366")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; } 
    
    /// <summary>
    /// Party to which a cheque is made payable.
    /// </summary>
    [IsoId("_QbdK_dp-Ed-ak6NoX_4Aeg_-241775384")]
    [DisplayName("Payee Identification")]
    [IsoXmlTag("PyeeId")]
    public required PartyIdentification2Choice_ PayeeIdentification { get; init; } 
    
    /// <summary>
    /// Financial institution on which a cheque is drawn, ie, the financial institution that services the account of the entity that issued the cheque.
    /// </summary>
    [IsoId("_QbdK_tp-Ed-ak6NoX_4Aeg_-241775426")]
    [DisplayName("Drawee Identification")]
    [IsoXmlTag("DrweeId")]
    public FinancialInstitutionIdentification3Choice_? DraweeIdentification { get; init; } 
    
    /// <summary>
    /// Account owner that issues a cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
    /// </summary>
    [IsoId("_QbmU4Np-Ed-ak6NoX_4Aeg_-241775434")]
    [DisplayName("Drawer Identification")]
    [IsoXmlTag("DrwrId")]
    public PartyIdentification2Choice_? DrawerIdentification { get; init; } 
    
    
    #nullable disable
    
}
