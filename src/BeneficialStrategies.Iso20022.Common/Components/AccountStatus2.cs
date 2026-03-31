// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of an account.
/// </summary>
[IsoId("_N5eWMEy9EeafiMTDrtSnyw")]
[DisplayName("Account Status")]
public record AccountStatus2
{
    /// <summary>
    /// Account can be used for its intended purpose.
    /// </summary>
    [IsoId("_USUHkEy9EeafiMTDrtSnyw")]
    [DisplayName("Enabled")]
    [IsoXmlTag("Nbld")]
    public EnabledStatusReason1Choice_? Enabled { get; init; }

    /// <summary>
    /// Account cannot temporarily be used for its intended purpose.
    /// </summary>
    [IsoId("_We568Ey9EeafiMTDrtSnyw")]
    [DisplayName("Disabled")]
    [IsoXmlTag("Dsbld")]
    public DisabledStatusReason1Choice_? Disabled { get; init; }

    /// <summary>
    /// Account change is pending approval.
    /// </summary>
    [IsoId("_XztxwEy9EeafiMTDrtSnyw")]
    [DisplayName("Pending")]
    [IsoXmlTag("Pdg")]
    public PendingStatusReason1Choice_? Pending { get; init; }

    /// <summary>
    /// Account opening is pending.
    /// </summary>
    [IsoId("_Z6oqEGCJEeabZtzjEVWYCQ")]
    [DisplayName("Pending Opening")]
    [IsoXmlTag("PdgOpng")]
    public PendingOpeningStatusReason1Choice_? PendingOpening { get; init; }

    /// <summary>
    /// Account is temporary and can be partially used for its intended purpose. The account will be fully available for use when the account servicer has received all relevant documents.
    /// </summary>
    [IsoId("_bdJWkEy9EeafiMTDrtSnyw")]
    [DisplayName("Proforma")]
    [IsoXmlTag("Profrm")]
    public ProformaStatusReason1Choice_? Proforma { get; init; }

    /// <summary>
    /// Account is closed.
    /// </summary>
    [IsoId("_dPQNYEy9EeafiMTDrtSnyw")]
    [DisplayName("Closed")]
    [IsoXmlTag("Clsd")]
    public ClosedStatusReason1Choice_? Closed { get; init; }

    /// <summary>
    /// Account closure is pending.
    /// </summary>
    [IsoId("_O96L4GCLEeabZtzjEVWYCQ")]
    [DisplayName("Closure Pending")]
    [IsoXmlTag("ClsrPdg")]
    public ClosurePendingStatusReason1Choice_? ClosurePending { get; init; }

    /// <summary>
    /// Status is a bilaterally agreed status.
    /// </summary>
    [IsoId("_h6vsIEy9EeafiMTDrtSnyw")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public ValueList<OtherAccountStatus1> Other { get; init; } = [];
}
