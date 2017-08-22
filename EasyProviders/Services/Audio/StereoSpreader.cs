namespace EasyProviders.Services.Audio {
    public sealed class StereoSpreader {
        private float m_delayTime = 0.028f;

        private int m_delayLength;

        private int m_bufferLength;

        private float[] m_delayBuffer;

        private int m_dataLength;

        private int m_channels;

    }
}

