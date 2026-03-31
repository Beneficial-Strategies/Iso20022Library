// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of driving license.
/// </summary>
[IsoId("_JUVlIFzPEeeDqe2giKl0eQ")]
[DisplayName("Driving License")]
public record DrivingLicense1
{
    /// <summary>
    /// Type of driving license.
    /// </summary>
    [IsoId("_ULFsQFzPEeeDqe2giKl0eQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Type { get; init; }

    /// <summary>
    /// Form of driving license.
    /// </summary>
    [IsoId("_fx27EFzPEeeDqe2giKl0eQ")]
    [DisplayName("Form")]
    [IsoXmlTag("Form")]
    public PresentationMedium2Code? Form { get; init; }

    /// <summary>
    /// Identification of the driver license (for example, driver license number).
    /// </summary>
    [IsoId("_o_nEEFzPEeeDqe2giKl0eQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text Identification { get; init; }

    /// <summary>
    /// Authority assigning an identification to a driver license.
    /// </summary>
    [IsoId("_Ssi1MFzQEeeDqe2giKl0eQ")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public LegalStructure1Code? Assigner { get; init; }

    /// <summary>
    /// Date of issuance of the driving license.
    /// </summary>
    [IsoId("_clDLYFzQEeeDqe2giKl0eQ")]
    [DisplayName("Issuance Date")]
    [IsoXmlTag("IssncDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssuanceDate { get; init; }

    /// <summary>
    /// Expiration date of the driving license (if and when relevant).
    /// </summary>
    [IsoId("_kRaaIFzQEeeDqe2giKl0eQ")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ExpirationDate { get; init; }

    /// <summary>
    /// Country issuing the driver license.
    /// </summary>
    [IsoId("_uLAVcFzQEeeDqe2giKl0eQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; }

    /// <summary>
    /// State issuing the driver license (if and when relevant).
    /// </summary>
    [IsoId("_7cuqMFzQEeeDqe2giKl0eQ")]
    [DisplayName("State")]
    [IsoXmlTag("Stat")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? State { get; init; }

    /// <summary>
    /// Province issuing the driver license (if and when relevant).
    /// </summary>
    [IsoId("_IyfKYFzREeeDqe2giKl0eQ")]
    [DisplayName("Province")]
    [IsoXmlTag("Prvc")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? Province { get; init; }

    /// <summary>
    /// Other authority issuing a driver license.
    /// </summary>
    [IsoId("_POT-UFzREeeDqe2giKl0eQ")]
    [DisplayName("Other Authority")]
    [IsoXmlTag("OthrAuthrty")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? OtherAuthority { get; init; }
}
