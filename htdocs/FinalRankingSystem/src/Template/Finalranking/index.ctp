<?php
/**
 * @var \App\View\AppView $this
 * @var \App\Model\Entity\Finalranking[]|\Cake\Collection\CollectionInterface $finalranking
 */
?>
<nav class="large-3 medium-4 columns" id="actions-sidebar">
    <ul class="side-nav">
        <li class="heading"><?= __('Actions') ?></li>
        <li><?= $this->Html->link(__('New Finalranking'), ['action' => 'add']) ?></li>
    </ul>
</nav>
<div class="finalranking index large-9 medium-8 columns content">
    <h3><?= __('Finalranking') ?></h3>
    <table cellpadding="0" cellspacing="0">
        <thead>
            <tr>
                <th scope="col"><?= $this->Paginator->sort('id') ?></th>
                <th scope="col"><?= $this->Paginator->sort('Score') ?></th>
                <th scope="col"><?= $this->Paginator->sort('Date') ?></th>
                <th scope="col" class="actions"><?= __('Actions') ?></th>
            </tr>
        </thead>
        <tbody>
            <?php foreach ($finalranking as $finalranking): ?>
            <tr>
                <td><?= $this->Number->format($finalranking->id) ?></td>
                <td><?= $this->Number->format($finalranking->Score) ?></td>
                <td><?= h($finalranking->Date) ?></td>
                <td class="actions">
                    <?= $this->Html->link(__('View'), ['action' => 'view', $finalranking->id]) ?>
                    <?= $this->Html->link(__('Edit'), ['action' => 'edit', $finalranking->id]) ?>
                    <?= $this->Form->postLink(__('Delete'), ['action' => 'delete', $finalranking->id], ['confirm' => __('Are you sure you want to delete # {0}?', $finalranking->id)]) ?>
                </td>
            </tr>
            <?php endforeach; ?>
        </tbody>
    </table>
    <div class="paginator">
        <ul class="pagination">
            <?= $this->Paginator->first('<< ' . __('first')) ?>
            <?= $this->Paginator->prev('< ' . __('previous')) ?>
            <?= $this->Paginator->numbers() ?>
            <?= $this->Paginator->next(__('next') . ' >') ?>
            <?= $this->Paginator->last(__('last') . ' >>') ?>
        </ul>
        <p><?= $this->Paginator->counter(['format' => __('Page {{page}} of {{pages}}, showing {{current}} record(s) out of {{count}} total')]) ?></p>
    </div>
</div>
