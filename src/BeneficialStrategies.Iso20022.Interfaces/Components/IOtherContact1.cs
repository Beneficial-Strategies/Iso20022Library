// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_6SokSZqlEeGSON8vddiWzQ_1969673172")]
public interface IOtherContact1 : IIsoComponent
{
    /// <summary>
    /// Method used to contact the financial institution’s contact for the specific tax region.
    /// </summary>
    [IsoId("_6SokSpqlEeGSON8vddiWzQ_444512870")]
    [DisplayName("Channel Type")]
    [IsoXmlTag("ChanlTp")]
    IsoMax4Text ChannelType { get; }

    /// <summary>
    /// Communication value such as phone number or email address.
    /// </summary>
    [IsoId("_6SokS5qlEeGSON8vddiWzQ_938910947")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IsoMax128Text? Identification { get; }
}
