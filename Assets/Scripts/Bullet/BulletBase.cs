using System;
using System.Collections.Generic;
using UnityEngine;
using JackUtil;

namespace SaveRedNS {

    public class BulletBase : MonoBehaviour {

        [HideInInspector]
        public Rigidbody2D rig;

        public float bpm = 120;
        float speed;

        protected virtual void Awake() {

            rig = GetComponent<Rigidbody2D>();

        }

        public void Init(ColorType _color, Vector2 _dir, float _speed) {

            tag = TagCollection.GetBulletTag(_color);

            if (_color == ColorType.Green) {

                GetComponent<SpriteRenderer>().sprite = SpriteCollection.Instance.greenBullet;

            }

            rig.velocity = _dir * _speed;

        }

    }

}