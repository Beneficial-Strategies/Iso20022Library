// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a consumer or a company.
/// </summary>
[IsoId("_oDA8ivJjEeiJn9rM2Znz2w")]
[DisplayName("Customer")]
public record Customer4
{
    /// <summary>
    /// Type of customer.
    /// </summary>
    [IsoId("_oDA8kPJjEeiJn9rM2Znz2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CustomerType2Code? Type { get; init; }

    /// <summary>
    /// Reference number provided by a cardholder or customer to card acceptor to facilitate communication and record keeping.  The value may be a reference number, code, or generic number.
    /// </summary>
    [IsoId("_oDA8kfJjEeiJn9rM2Znz2w")]
    [DisplayName("Reference Number")]
    [IsoXmlTag("RefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReferenceNumber { get; init; }

    /// <summary>
    /// Identification of the customer recognized by the taxation authority.
    /// </summary>
    [IsoId("_oDA8jfJjEeiJn9rM2Znz2w")]
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? TaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Contact at the company.
    /// </summary>
    [IsoId("_oDA8jvJjEeiJn9rM2Znz2w")]
    [DisplayName("Authorised Contact Company")]
    [IsoXmlTag("AuthrsdCtctCpny")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AuthorisedContactCompany { get; init; }

    /// <summary>
    /// Corporate individual or company (cardholder or their company) to be contacted for authorised purchases.
    /// </summary>
    [IsoId("_oDA8jPJjEeiJn9rM2Znz2w")]
    [DisplayName("Authorised Contact Name")]
    [IsoXmlTag("AuthrsdCtctNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AuthorisedContactName { get; init; }

    /// <summary>
    /// Phone number of an individual or
    /// company contacted for company authorised purchases.
    /// </summary>
    [IsoId("_oDA8j_JjEeiJn9rM2Znz2w")]
    [DisplayName("Authorised Contact Phone Number")]
    [IsoXmlTag("AuthrsdCtctPhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? AuthorisedContactPhoneNumber { get; init; }

    /// <summary>
    /// Very Important Person indicator.
    /// </summary>
    [IsoId("_oDA8i_JjEeiJn9rM2Znz2w")]
    [DisplayName("VIP Indicator")]
    [IsoXmlTag("VIPInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? VIPIndicator { get; init; }

    /// <summary>
    /// Customer relationship identifier.
    /// </summary>
    [IsoId("_oDA8kvJjEeiJn9rM2Znz2w")]
    [DisplayName("Customer Relationship")]
    [IsoXmlTag("CstmrRltsh")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CustomerRelationship { get; init; }
}
