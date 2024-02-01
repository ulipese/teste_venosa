import React from 'react';

function Colors() {
  const newColor =
    '#' + ((Math.random() * 0xffffff) << 0).toString(16).padStart(6, '0'); // seria atualizado a
  // cada chamada(de 1 segundo) feita pelo Unity

  return <div className="Colors">{newColor}</div>;
}

export default Colors;
