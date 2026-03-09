// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Represents a specific market trading session. It is used to identify a portion of the session where the execution might take place (&quot;after market&quot;, &quot;pre-market&quot;).|It is used to support order routing, quoting, and trade and market data reporting. For instance, orders can be routed to one or more Trading Sessions. Examples of Trading Session usage may be to facilitate extended hours trading, to differentiate between concurrent electronic and open-outcry trading, or to differentiate block and/or oddlot trading.|It is used by Exchanges, ECN&apos;s, and ATS&apos;s.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YmerpNp-Ed-ak6NoX_4Aeg_336259624")]
[Description(@"Represents a specific market trading session. It is used to identify a portion of the session where the execution might take place (""after market"", ""pre-market"").|It is used to support order routing, quoting, and trade and market data reporting. For instance, orders can be routed to one or more Trading Sessions. Examples of Trading Session usage may be to facilitate extended hours trading, to differentiate between concurrent electronic and open-outcry trading, or to differentiate block and/or oddlot trading.|It is used by Exchanges, ECN's, and ATS's.")]
public enum TradeExecutionSessionCode
{
    /// <summary>
    /// Opening Session. 8: 00 AM - 9: 30 AM Eastern of the Archipelago Exchange (Pacific Stock Exchange).
    /// Encoded/decoded by serializers as &quot;ACHO&quot;.
    /// </summary>
    [EnumMember(Value = "ACHO")]
    [IsoId("_Ymerpdp-Ed-ak6NoX_4Aeg_336259625")]
    [Description(@"Opening Session. 8: 00 AM - 9: 30 AM Eastern of the Archipelago Exchange (Pacific Stock Exchange).")]
    ArchipelagoOpeningSession,
    
    /// <summary>
    /// Core Trading Session. 9: 30 AM - 4: 00 PM Eastern of the Archipelago Exchange (Pacific Stock Exchange).
    /// Encoded/decoded by serializers as &quot;ACHC&quot;.
    /// </summary>
    [EnumMember(Value = "ACHC")]
    [IsoId("_Ymerptp-Ed-ak6NoX_4Aeg_336259626")]
    [Description(@"Core Trading Session. 9: 30 AM - 4: 00 PM Eastern of the Archipelago Exchange (Pacific Stock Exchange).")]
    ArchipelagoCoreSession,
    
    /// <summary>
    /// Late Trading Session. 4: 00 PM - 8: 00 PM Easternof the Archipelago Exchange (Pacific Stock Exchange).
    /// Encoded/decoded by serializers as &quot;ACHL&quot;.
    /// </summary>
    [EnumMember(Value = "ACHL")]
    [IsoId("_Ymerp9p-Ed-ak6NoX_4Aeg_336259627")]
    [Description(@"Late Trading Session. 4: 00 PM - 8: 00 PM Easternof the Archipelago Exchange (Pacific Stock Exchange).")]
    ArchipelagoLateSession,
    
    /// <summary>
    /// Early Morning Electronic Trading Session of the Chicago Board Options Exchange.
    /// Encoded/decoded by serializers as &quot;WAM1&quot;.
    /// </summary>
    [EnumMember(Value = "WAM1")]
    [IsoId("_YmerqNp-Ed-ak6NoX_4Aeg_336259635")]
    [Description(@"Early Morning Electronic Trading Session of the Chicago Board Options Exchange.")]
    ChicagoBoardOptionsEarlySession,
    
    /// <summary>
    /// Regular hours open outcry market of the Chicago Board Options Exchange.
    /// Encoded/decoded by serializers as &quot;WMAI&quot;.
    /// </summary>
    [EnumMember(Value = "WMAI")]
    [IsoId("_YmocoNp-Ed-ak6NoX_4Aeg_336259636")]
    [Description(@"Regular hours open outcry market of the Chicago Board Options Exchange.")]
    ChicagoBoardOptionsRegularHours,
    
    /// <summary>
    /// An electronic communication system operated by Nagoya Securities Exchange.
    /// Encoded/decoded by serializers as &quot;NNET&quot;.
    /// </summary>
    [EnumMember(Value = "NNET")]
    [IsoId("_Ymocodp-Ed-ak6NoX_4Aeg_336259637")]
    [Description(@"An electronic communication system operated by Nagoya Securities Exchange.")]
    NagoyaExchange,
    
    /// <summary>
    /// An electronic communication system by which the Osaka Securities Exchange (OSE), OSE members (Securities companies) and investors are directly connected with each other via a multi-layered computer network.
    /// Encoded/decoded by serializers as &quot;JNET&quot;.
    /// </summary>
    [EnumMember(Value = "JNET")]
    [IsoId("_Ymocotp-Ed-ak6NoX_4Aeg_336259638")]
    [Description(@"An electronic communication system by which the Osaka Securities Exchange (OSE), OSE members (Securities companies) and investors are directly connected with each other via a multi-layered computer network.")]
    OsakaExchange,
    
    /// <summary>
    /// An off hour trade session of Tokyo Stock Exchange (TSE) for TSE listed stocks only. For Single/List trade.
    /// Encoded/decoded by serializers as &quot;TOS1&quot;.
    /// </summary>
    [EnumMember(Value = "TOS1")]
    [IsoId("_Ymoco9p-Ed-ak6NoX_4Aeg_336259639")]
    [Description(@"An off hour trade session of Tokyo Stock Exchange (TSE) for TSE listed stocks only. For Single/List trade.")]
    TokyoSingleListedTrade,
    
    /// <summary>
    /// An off hour trade session of Tokyo Stock Exchange (TSE) for TSE listed stocks only. For trade based on close price of regular trading session.
    /// Encoded/decoded by serializers as &quot;TOS2&quot;.
    /// </summary>
    [EnumMember(Value = "TOS2")]
    [IsoId("_YmocpNp-Ed-ak6NoX_4Aeg_336259640")]
    [Description(@"An off hour trade session of Tokyo Stock Exchange (TSE) for TSE listed stocks only. For trade based on close price of regular trading session.")]
    TokyoClosingPriceTrade,
    
}
