// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information about the delivery details, beneficial owner details, etc.
/// </summary>
[IsoId("_UMZtCNp-Ed-ak6NoX_4Aeg_302800554")]
[DisplayName("Corporate Action Additional Information")]
public record CorporateActionAdditionalInformation1
{
    /// <summary>
    /// Provides information about the beneficial owner of the securities.
    /// </summary>
    [IsoId("_UMjeANp-Ed-ak6NoX_4Aeg_-2045712044")]
    [DisplayName("Beneficial Owner Details")]
    [IsoXmlTag("BnfclOwnrDtls")]
    public BeneficialOwner1? BeneficialOwnerDetails { get; init; }

    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_UMjeAdp-Ed-ak6NoX_4Aeg_-1779080684")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? RegistrationDetails { get; init; }

    /// <summary>
    /// Identification of the receiver of outturned resources (cash/securities) in case the resources need to be delivered outside the CSD.
    /// </summary>
    [IsoId("_UMjeAtp-Ed-ak6NoX_4Aeg_-1632874072")]
    [DisplayName("Receiver Identification")]
    [IsoXmlTag("RcvrId")]
    public PartyIdentification2Choice_? ReceiverIdentification { get; init; }

    /// <summary>
    /// Whether or not certification is required from the account owner. |Y: certification required |N: no certification required.
    /// </summary>
    [IsoId("_UMjeA9p-Ed-ak6NoX_4Aeg_-1477351985")]
    [DisplayName("Certification Indicator")]
    [IsoXmlTag("CertfctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationIndicator { get; init; }

    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_UMjeBNp-Ed-ak6NoX_4Aeg_-1477351955")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; }

    /// <summary>
    /// Provides information about the delivery details of proceeds.
    /// </summary>
    [IsoId("_UMjeBdp-Ed-ak6NoX_4Aeg_138497699")]
    [DisplayName("Delivery Details")]
    [IsoXmlTag("DlvryDtls")]
    public ProceedsDelivery1? DeliveryDetails { get; init; }

    /// <summary>
    /// Provides additional details pertaining to the corporate action instruction.
    /// </summary>
    [IsoId("_UMjeBtp-Ed-ak6NoX_4Aeg_1410048508")]
    [DisplayName("Additional Instruction")]
    [IsoXmlTag("AddtlInstr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInstruction { get; init; }
}
