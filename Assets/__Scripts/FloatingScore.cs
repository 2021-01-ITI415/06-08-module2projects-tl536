using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum eFSState
{
    idle,
    pre,
    active,
    post
}
// FloatingScore can move itself on screen following a Bézier curve
public class FloatingScore : MonoBehaviour
{
    [Header("Set Dynamically")]
    public eFSState state = eFSState.idle;
    [SerializeField]
    protected int _score = 0;
    public string scoreString;
    // The score property sets both _score and scoreString
    public int score
    {
        get
        {
            return (_score);
        }
        set
        {
            _score = value;
            scoreString = _score.ToString("N0");// "N0" adds commas to the num
                                                // Search "C# Standard Numeric Format Strings" for ToString formats
            GetComponent<Text>().text = scoreString;
        }
    }
    public List<Vector2> bezierPts; // Bézier points for movement
    public List<float> fontSizes; // Bézier points for font scaling
    public float timeStart = -1f;
    public float timeDuration = 1f;
    public string easingCurve = Easing.InOut; // Uses Easing in Utils.cs
                                              // The GameObject that will receive the SendMessage when this is done moving
    public GameObject reportFinishTo = null;
    private RectTransform rectTrans;
    private Text txt;
    public enum eFSState
    {
        idle,
        pre,
        active,
        post
    }
    // FloatingScore can move itself on screen following a Bézier curve
    public class FloatingScore : MonoBehaviour
    {
        [Header("Set Dynamically")]
        public eFSState state = eFSState.idle;
        [SerializeField]
        protected int _score = 0;
        public string scoreString;
        // The score property sets both _score and scoreString
        public int score
        {
            get
            {
                return (_score);
            }
            set
            {
                _score = value;
                scoreString = _score.ToString("N0");// "N0" adds commas to the num
                                                    // Search "C# Standard Numeric Format Strings" for ToString formats
                GetComponent<Text>().text = scoreString;
            }
        }
        public List<Vector2> bezierPts; // Bézier points for movement
        public List<float> fontSizes; // Bézier points for font scaling
        public float timeStart = -1f;
        public float timeDuration = 1f;
        public string easingCurve = Easing.InOut; // Uses Easing in Utils.cs
                                                  // The GameObject that will receive the SendMessage when this is done moving
        public GameObject reportFinishTo = null;
        private RectTransform rectTrans;
        private Text txt;
    }
    // Use Bézier curve to move this to the right point
    Vector2 pos = Utils.Bezier(uC, bezierPts);
    // RectTransform anchors can be used to position UI objects relative
    // to total size of the screen
    rectTrans.anchorMin = rectTrans.anchorMax = pos;
if (fontSizes != null && fontSizes.Count>0) {
// If fontSizes has values in it
// ...then adjust the fontSize of this GUIText
int size = Mathf.RoundToInt(Utils.Bezier(uC, fontSizes));
    GetComponent<Text>().fontSize = size;

}
}
}
