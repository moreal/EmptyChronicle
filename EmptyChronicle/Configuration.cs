namespace EmptyChronicle;

public class Configuration
{
    // Networks
    public string? AppProtocolVersionToken { get; set; }

    public string[]? TrustedAppProtocolVersionSigners { get; set; }

    public string[]? IceServerStrings { get; set; }

    public string[]? PeerStrings { get; set; }

    // Blockchains
    public string? GenesisBlockPath { get; init; }

    public string? StorePath { get; set; }

    public ActionEvaluatorRange[]? ActionEvaluatorRanges { get; set; }

    public ushort? Port { get; set; }
}
